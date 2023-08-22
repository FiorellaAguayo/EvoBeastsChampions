using System.Text.RegularExpressions;
using Entities;

using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace EntitiesServices
{
    public class UserValidation
    {
        private UserService _userService;

        public UserValidation() 
        {
            _userService = new UserService();
        }

        public enum ValidationStatus
        {
            Success,
            DuplicateAlias,
            DuplicateEmail,
            DoesNotExist,
            InvalidEmail,
            IsEmpty
        }

        public async Task<ValidationStatus> ValidateUserToCreate(User user)
        {
            if(IsEmailFormatValid(user.Email))
            {
                if(await _userService.AliasExists(user.Alias))
                {
                    return ValidationStatus.DuplicateAlias;
                }
                else if(await _userService.FieldExists("Email", user.Email))
                {
                    return ValidationStatus.DuplicateEmail;
                }
                else
                {
                    await _userService.CreateUser(user, user.Alias);
                    return ValidationStatus.Success;
                }
            }
            else
            {
                return ValidationStatus.InvalidEmail;
            }
        }

        public async Task<ValidationStatus> ValidateUserToLogin(User user)
        {
            if (!await _userService.AliasExists(user.Alias))
            {
                return ValidationStatus.DoesNotExist;
            }
            else
            {
                return ValidationStatus.Success;
            }
        }

        public async Task<ValidationStatus> SendCode(string email)
        {
            if(IsEmailFormatValid(email))
            {
                if(await _userService.FieldExists("Email", email))
                {
                    return ValidationStatus.Success;
                }
                else
                {
                    return ValidationStatus.DoesNotExist;
                }
            }
            return ValidationStatus.InvalidEmail;
        }

        public ValidationStatus ValidateCode(string random, string code, string email)
        {
            if(ValidateEqualsCodes(random, code))
            {
                return ValidationStatus.Success;
            }
            else if(string.IsNullOrEmpty(code))
            {
                return ValidationStatus.IsEmpty;
            }
            else
            {
                return ValidationStatus.DoesNotExist;
            }
        }

        public async Task<bool> ChangePassword(string email, string passwordTxbOne, string passwordTxbTwo)
        {
            if(ValidateEqualsPasswords(passwordTxbOne, passwordTxbTwo))
            {
                var user = await _userService.GetUserByField("Email", email);
                if(user != null)
                {
                    user.Password = passwordTxbOne;
                    await _userService.UpdateUser(user, user.Alias);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public bool ValidateEqualsPasswords(string passwordTxbOne, string passwordTxbTwo)
        {
            if(string.Equals(passwordTxbOne, passwordTxbTwo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // hacer de otra manera estos metodos asi no se repite codigo
        public bool ValidateEqualsCodes(string codeTxbOne, string codeTxbTwo)
        {
            if (string.Equals(codeTxbOne, codeTxbTwo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsEmailFormatValid(string email)
        {
            if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}