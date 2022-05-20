// See https://aka.ms/new-console-template for more information

using System;
namespace VerifyPassword
{
    public class Password
    {
        //static string password = "soL44Sol";
        static int MinPasswordLength = 8;
        static bool isValid = true;
        public static bool Verify(string password) 
        {
            // string password="solaris";     
            //TO CHECK PASSWORD LENGTH
            try
            {
                if (password.Length < MinPasswordLength)
                {
                     throw new ArgumentException("The password is less than 8 digits");
                    
                }

                ValidateNull();
            }

            catch (Exception e)
            {
                throw new Exception("The password is less than 8 digits");
                
            }

           

            //TO CHECH PASSWORD NULL OR NOT
            void ValidateNull()
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(password))
                    {
                        throw new Exception("The password cannot be null");
                      
                    }

                    ValidateDigit();
                }
                catch (Exception e)
                {
                    throw new Exception("The password cannot be null");
                }
            }

            //TO CHECK PASSWORD CONTAINS DIGIT
            void ValidateDigit()
            {
                try
                {
                    if (!password.Any(char.IsDigit))
                    {
                        throw new Exception("The password should have atleast one digit");
                       
                    }

                    ValidateUpper();
                }
                catch (Exception e)
                {
                    throw new Exception("The password should have atleast one digit");
                }
            }

            //TO CHECK IT CONTAINS UPPER CASE OR NOT
            void ValidateUpper()
            {
                try
                {
                    if (!password.Any(char.IsUpper))
                    {
                         throw new Exception("The password should contain uppercase");
                       
                    }

                    ValidateLower();
                }
                catch (Exception e)
                {
                    throw new Exception("The password should contain uppercase");
                }
            }

            //TO CHECK IT CONTAINS LOWER CASE OR NOT
            void ValidateLower()
            {
                try
                {
                    if (!password.Any(char.IsLower))
                    {
                         throw new Exception("The password should contain lower case");
                            
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("The password should contain lower case");
                }
            }
            
           
            return isValid;
          

        }
    }
}
