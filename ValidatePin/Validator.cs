using System;

namespace Validate.Pin
{
    public class PinValidator
    {
        //Responsible for checking if pin has any non-digit character.
        public bool IsaNumber(string pin)
        {
            //Returns false has soon has any non-digit character is found.
            foreach (char c in pin)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool ValidatePin(string pin)
        {
            //Starts by checking pin's length.
            if (pin.Length != 4 && pin.Length != 6)
            {
                return false;   //If invalid, return false.
            }
            //If length is within permited, check if it contains only numbers.
            else
            {
                if (!IsaNumber(pin))            //If pin has letter...
                {
                    return false;               //Returns false.
                }
            }

            return true;
        }
    }
}