using System;
using System.Text.RegularExpressions;

namespace Validate.Pin
{
    public class PinValidator
    {
        public bool ValidatePin(string pin) => new Regex("\\A((\\d{4})|(\\d{6}))\\z").IsMatch(pin);
    }
}