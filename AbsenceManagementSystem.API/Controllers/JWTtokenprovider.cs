using System.Security.Cryptography;

namespace AbsenceManagementSystem.API.Controllers
{
    public class JWTtokenprovider
    {
        private readonly byte[] _key;

        public JWTtokenprovider()
        {
            _key = GenerateKey();
        }

        public byte[] GetKey()
        {
            return _key;
        }

        private byte[] GenerateKey()
        {
            var key = new byte[32]; // 256-bit key
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(key);
            return key;
        }
    }
}
