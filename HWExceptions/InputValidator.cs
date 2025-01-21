using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWExceptions
{
    public class InputValidator
    {
        public static bool IsInputCorrect(string login, string password, string passwordConfirmation)
        {
            try
            {
                ValidateLogin(login);
                ValidatePassword(password, passwordConfirmation);
            }
            catch(WrongLoginException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (WrongPasswordException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public static void ValidateLogin(string login) 
        {
            string _message = String.Empty;
            bool isValid = true;
            if(login == null || login.Length == 0)
            {
                _message += "Логин не введен. ";
                isValid = false;
            }
            if(login != null && login.Length > 19)
            {
                _message += "Логин больше 20 символов. ";
                isValid = false;
            }
            if(login != null &&  login.Contains(' '))
            {
                _message += "Логин содержит пробелы. ";
                isValid = false;
            }
            if(!isValid)
            {
                throw new WrongLoginException(_message);
            }
        }
        
        public static void ValidatePassword(string password, string passwordConfirmation)
        {
            string _message = String.Empty;
            bool isValid = true;
            if (password == null || passwordConfirmation == null)
            {
                _message += "Пароль не введен. ";
                isValid = false;
            }
            else
            {
                if (password.Length > 19)
                {
                    _message += "Длина пароля больше 19 символов. ";
                    isValid = false;
                }
                if (password != passwordConfirmation)
                {
                    _message += "Пароли не совпадают. ";
                    isValid = false;
                }
                if (password.Contains(' '))
                {
                    _message += "Пароль содержит пробелы. ";
                    isValid = false;
                }
                if (!password.Any(char.IsDigit))
                {
                    _message += "Пароль не содержит цифры. ";
                    isValid = false;
                }
                if (!isValid)
                {
                    throw new WrongPasswordException(_message);
                }
            }
            
        }

    }
}
