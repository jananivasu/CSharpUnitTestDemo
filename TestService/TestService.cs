using System;

namespace Test.Services
{
    public class TestService {
        public bool IsEven(int value) {
            if (value %2 == 0) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}