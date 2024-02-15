using System;
using System.Collections.Generic;

namespace CSIntermediate.Classes
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie() { 
        _dictionary = new Dictionary<string, string>();
        }
        public void SetItem(string key, string value)
        {

        }

        public void GetItem(string key)
        {

        }
        public string this[string key]
        {
            get { 
                return _dictionary[key];
            }
            set { _dictionary[key] = value; }
        }
    }
}
