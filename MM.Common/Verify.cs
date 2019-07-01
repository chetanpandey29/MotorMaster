using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MM.Common
{
    public static class Verify
    {

        public static void IsAssignableFrom<T>(string name, Type value)
        {
            IsNotNullOrEmpty("name", name);

            IsNotNull("value", value);

            if (!typeof(T).IsAssignableFrom(value))
            {
                throw new ArgumentException(name, typeof(T).Name);
            }
        }
        public static void IsAssignableFrom(string name, object value, Type type)
        {
            IsNotNullOrEmpty("name", name);

            IsNotNull("value", value);

            IsNotNull("type", type);

            if (!type.IsAssignableFrom(value.GetType()))
            {
                throw new ArgumentException(name, type.Name);
            }
        }
        public static void IsBool(string name, string value)
        {
            IsNotNullOrEmpty("name", name);
            bool flag;
            if (!Boolean.TryParse(value, out flag))
            {
                throw new ArgumentException(name, value);
            }
        }
        public static void IsCaseInsensitive<T>(string name, Dictionary<string, T> dictionary)
        {
            IsNotNullOrEmpty("name", name);
            IsNotNull("dictionary", dictionary);

            IEqualityComparer<string> comparer = dictionary.Comparer;

            if (!comparer.Equals(StringComparer.OrdinalIgnoreCase))
            {
                throw new ArgumentException(name, "case insensitive");
            }
        }
        public static void IsDate(string name, object value)
        {
            IsNotNullOrEmpty("name", name);

            IsNotNull(name, value);

            string valueAsString = value.ToString();

            try
            {
                DateTime date = DateTime.Parse(valueAsString);
            }
            catch
            {
                throw new ArgumentException(name, valueAsString);
            }
        }
        public static void IsLength(string name, string value, int length)
        {
            IsNotNullOrEmpty("name", name);

            if (value.Length == length)
            {
                throw new ArgumentException(name, value);
            }
        }
        public static void IsLengthGreaterThan(string name, string value, int length)
        {
            IsNotNullOrEmpty("name", name);

            if (value.Length <= length)
            {
                throw new ArgumentException(name, value);
            }
        }
        public static void IsLengthLessThan(string name, string value, int length)
        {
            IsNotNullOrEmpty("name", name);

            if (value.Length >= length)
            {
                throw new ArgumentException(name, value);
            }
        }
        public static void IsNotDefault<T>(string name, T value) where T : struct
        {
            IsNotNullOrEmpty("name", name);

            if (EqualityComparer<T>.Default.Equals(value, default(T)))
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotEmpty(string name, ICollection value)
        {
            IsNotNullOrEmpty("name", name);

            if (value == null)
            {
                return;
            }

            if (value.Count == 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotEmpty(string name, string value)
        {
            if (name == null)
            {
                throw new ArgumentException("name");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("name");
            }

            if (value == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotEmpty<T>(string name, IEnumerable<T> value)
        {
            IsNotNullOrEmpty("name", name);

            if (value.Count() == 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotNegative(string name, decimal value)
        {
            IsNotNullOrEmpty("name", name);

            if (value < 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotNegative(string name, decimal? value)
        {
            IsNotNullOrEmpty("name", name);

            if (value.HasValue)
            {
                IsNotNegative(name, value.Value);
            }
        }
        public static void IsNotNegative(string name, string value)
        {
            IsNotNullOrEmpty("name", name);

            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            IsNumber(name, value);

            IsNotNegative(name, Convert.ToDecimal(value));
        }
        public static void IsNotNegative(string name, double value)
        {
            IsNotNullOrEmpty("name", name);

            if (value < 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotNegative(string name, double? value)
        {
            IsNotNullOrEmpty("name", name);

            if (value.HasValue)
            {
                IsNotNegative(name, value.Value);
            }
        }
        public static void IsNotNegative(string name, int value)
        {
            IsNotNullOrEmpty("name", name);

            if (value < 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotNegative(string name, int? value)
        {
            if (value.HasValue)
            {
                IsNotNegative(name, value.Value);
            }
        }
        public static void IsNotNegative(string name, long value)
        {
            IsNotNullOrEmpty("name", name);

            if (value < 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotNegative(string name, long? value)
        {
            if (value.HasValue)
            {
                IsNotNegative(name, value.Value);
            }
        }
        public static void IsNotNullAndIsPositive(string name, decimal? value)
        {
            IsNotNull(name, value);

            IsPositive(name, value);
        }
        public static void IsNotNullOrDefault<T>(string name, T? value) where T : struct
        {
            IsNotNull(name, value);
            IsNotDefault(name, value.GetValueOrDefault());
        }
        public static void IsNotNullOrEmpty(string name, ICollection value)
        {
            IsNotNullOrEmpty("name", name);

            IsNotNull(name, value);

            IsNotEmpty(name, value);
        }
        public static void IsNotNullOrEmpty(string name, string value)
        {
            IsNotNull("name", name);

            IsNotEmpty("name", name);

            IsNotNull(name, value);

            IsNotEmpty(name, value);
        }
        public static void IsNotNullOrEmpty<T>(string name, IEnumerable<T> value)
        {
            IsNotNullOrEmpty("name", name);

            IsNotNull(name, value);

            IsNotEmpty(name, value);
        }
        public static void IsNotZero(string name, decimal value)
        {
            IsNotNullOrEmpty("name", name);

            if (value == 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotZero(string name, decimal? value)
        {
            if (value.HasValue)
            {
                IsNotZero(name, value.Value);
            }
        }
        public static void IsNotZero(string name, double value)
        {
            IsNotNullOrEmpty("name", name);

            if (value == 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotZero(string name, double? value)
        {
            if (value.HasValue)
            {
                IsNotZero(name, value.Value);
            }
        }
        public static void IsNotZero(string name, int value)
        {
            IsNotNullOrEmpty("name", name);

            if (value == 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotZero(string name, int? value)
        {
            if (value.HasValue)
            {
                IsNotZero(name, value.Value);
            }
        }
        public static void IsNotZero(string name, long value)
        {
            IsNotNullOrEmpty("name", name);

            if (value == 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotZero(string name, long? value)
        {
            if (value.HasValue)
            {
                IsNotZero(name, value.Value);
            }
        }
        public static void IsNullOrNotDefault<T>(string name, T? value) where T : struct
        {
            IsNotNullOrEmpty("name", name);

            if (value.HasValue && EqualityComparer<T>.Default.Equals(value.Value, default(T)))
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNumber(string name, object value)
        {
            IsNotNullOrEmpty("name", name);
            int n;

            if (value == null || !int.TryParse(value.ToString(), out n))
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsPositive(string name, decimal value)
        {
            IsNotNullOrEmpty("name", name);

            if (value <= 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsPositive(string name, decimal? value)
        {
            if (value.HasValue)
            {
                IsPositive(name, value.Value);
            }
        }
        public static void IsPositive(string name, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            IsNumber(name, value);

            IsPositive(name, Convert.ToDecimal(value));
        }
        public static void IsPositive(string name, double value)
        {
            IsNotNullOrEmpty("name", name);

            if (value <= 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsPositive(string name, double? value)
        {
            if (value.HasValue)
            {
                IsPositive(name, value.Value);
            }
        }
        public static void IsPositive(string name, int value)
        {
            IsNotNullOrEmpty("name", name);

            if (value <= 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsPositive(string name, int? value)
        {
            if (value.HasValue)
            {
                IsPositive(name, value.Value);
            }
        }
        public static void IsPositive(string name, long value)
        {
            IsNotNullOrEmpty("name", name);

            if (value <= 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsPositive(string name, long? value)
        {
            if (value.HasValue)
            {
                IsPositive(name, value.Value);
            }
        }
        public static void IsNotPositive(string name, decimal value)
        {
            IsNotNullOrEmpty("name", name);

            if (value > 0)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotPositive(string name, decimal? value)
        {
            IsNotNullOrEmpty("name", name);

            if (value.HasValue)
            {
                IsNotPositive(name, value.Value);
            }
        }
        public static void IsNotNull(string name, Type value)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(name);
            }
            if (value == null)
            {
                throw new ArgumentException(name);
            }
        }
        public static void IsNotNull(string name, object value)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(name);
            }
            if (value == null)
            {
                throw new ArgumentException(name);
            }
        }

        public static void IsPhone(string name, string value)
        {
            IsNotNullOrEmpty("name", name);
            IsNotNullOrEmpty("name", value);
            if (!Regex.Match(value, @"^(\([2-9][0-9][0-9]\)|[2-9][0-9][0-9]) ?[-.,]? ?[2-9][0-9][0-9] ?[-.,]? ?\d{4}$").Success)
            {
                throw new ArgumentException(name);
            }
        }

        public static void IsEmail(string name, string value)
        {
            IsNotNullOrEmpty("name", name);
            IsNotNullOrEmpty("name", value);
            try
            {
                var addr = new System.Net.Mail.MailAddress(value);
                if(addr.Address != value)
                {
                    throw new ArgumentException(name);
                }
            }
            catch
            {
                throw new ArgumentException(name);
            }

        }

    }

}
