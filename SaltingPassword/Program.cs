using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SaltingPassword
{
  class Program
  {
    static void Main(string[] args)
    {
      PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
      HashWithSaltResult hashResultSha256 = pwHasher.HashWithSalt("ultra_safe_P455w0rD", 64, SHA256.Create());
      HashWithSaltResult hashResultSha512 = pwHasher.HashWithSalt("ultra_safe_P455w0rD", 64, SHA512.Create());

      Console.WriteLine(hashResultSha256.Salt);
      Console.WriteLine(hashResultSha256.Digest);
      Console.WriteLine();
      Console.WriteLine(hashResultSha512.Salt);
      Console.WriteLine(hashResultSha512.Digest);
    }
  }
}
