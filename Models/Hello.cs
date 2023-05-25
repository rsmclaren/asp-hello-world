using System;

namespace HelloWorld.Models {

    public class Hello {

        private string _message;

        public Hello(){
            _message = "hello world :)";
        }

        public string message {
            get {
                return _message;
            }
        }

    }
    
}