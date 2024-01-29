using SchoolManagementSystem.TeacherForms;
using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SchoolManagementSystem
{
    internal class Validators
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Account_Settings));
        public byte[] ConvertImageTobyte(Image image)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public System.Drawing.Image ConvertByteToImage(byte[] image)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(image))
            {
                try
                {
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    return img;
                }
                catch
                {
                    return (System.Drawing.Image)resources.GetObject("bunifuPictureBox1.Image");
                }
            }
        }
        public bool ValidateName(string name)
        {
            if (name.Length > 0 && Regex.Match(name, "^[A-Z][a-zA-Z]*$").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidateEmail(string email)
        {
            if (email.Length > 0 && Regex.Match(email, "^[a-zA-Z0-9]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidatePhone(int phn)
        {
            string phone = phn.ToString();
            if (phone.Length > 0 && Regex.Match(phone, "^[0-9]{10}$").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
            {
                age = age - 1;
            }
            return age;
        }

        public bool ValidateBirthDate(DateTime date)
        {
            if (CalculateAge(date) > 18)
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
