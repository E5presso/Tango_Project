using System;
using System.Security.Cryptography;
using System.Text;

namespace Core.Security
{
	/// <summary>
	/// 해쉬 타입을 지정합니다.
	/// </summary>
	public enum HashType
	{
		/// <summary>
		/// SHA1 해쉬입니다.
		/// </summary>
		SHA1,
		/// <summary>
		/// SHA256 해쉬입니다.
		/// </summary>
		SHA256,
		/// <summary>
		/// SHA384 해쉬입니다.
		/// </summary>
		SHA384,
		/// <summary>
		/// SHA512 해쉬입니다.
		/// </summary>
		SHA512
	}
	/// <summary>
	/// RSA 암호화 기능을 제공하는 클래스입니다..
	/// </summary>
	public class Rsa : IDisposable
	{
		private string privateKey;
		private readonly RSACryptoServiceProvider service;

		/// <summary>
		/// RSA 공개키입니다.
		/// </summary>
		public string PublicKey;
		/// <summary>
		/// RSA 개인키입니다.
		/// </summary>
		public string PrivateKey
		{
			get => privateKey;
			set
			{
				privateKey = value;
				service.FromXmlString(value);
				PublicKey = service.ToXmlString(false);
			}
		}

		/// <summary>
		/// RSA 클래스를 초기화합니다.
		/// </summary>
		public Rsa()
		{
			service = new RSACryptoServiceProvider();
			PrivateKey = service.ToXmlString(true);
		}
		/// <summary>
		/// RSA 클래스를 초기화합니다.
		/// </summary>
		/// <param name="certificate">X.509 인증서를 지정합니다.</param>
		public Rsa(X509 certificate)
		{
			service = new RSACryptoServiceProvider();
			if (certificate.HasPrivateKey) PrivateKey = certificate.PrivateKey;
			else
			{
				privateKey = service.ToXmlString(true);
				PublicKey = certificate.PublicKey;
			}
		}

		/// <summary>
		/// 데이터를 암호화합니다.
		/// </summary>
		/// <param name="data">암호화할 데이터입니다.</param>
		/// <param name="encrypted">암호화된 데이터입니다.</param>
		/// <returns>암호화 결과입니다.</returns>
		public bool Encrypt(byte[] data, out byte[] encrypted)
		{
			try
			{
				service.FromXmlString(PublicKey);
				encrypted = service.Encrypt(data, true);
				return true;
			}
			catch
			{
				encrypted = default;
				return false;
			}
		}
		/// <summary>
		/// 데이터를 복호화합니다.
		/// </summary>
		/// <param name="data">복호화할 데이터입니다.</param>
		/// <param name="decrypted">복호화된 데이터입니다.</param>
		/// <returns>복호화 결과입니다.</returns>
		public bool Decrypt(byte[] data, out byte[] decrypted)
		{
			try
			{
				service.FromXmlString(privateKey);
				decrypted = service.Decrypt(data, true);
				return true;
			}
			catch
			{
				decrypted = default;
				return false;
			}
		}
		/// <summary>
		/// 데이터를 암호화합니다.
		/// </summary>
		/// <param name="data">암호화할 데이터입니다.</param>
		/// <param name="encrypted">암호화된 데이터입니다.</param>
		/// <returns>암호화 결과입니다.</returns>
		public bool Encrypt(string data, out string encrypted)
		{
			bool result = Encrypt(Encoding.UTF8.GetBytes(data), out byte[] cipher);
			encrypted = Base64.GetString(cipher);
			return result;
		}
		/// <summary>
		/// 데이터를 복호화합니다.
		/// </summary>
		/// <param name="data">복호화할 데이터입니다.</param>
		/// <param name="decrypted">복호화된 데이터입니다.</param>
		/// <returns>복호화 결과입니다.</returns>
		public bool Decrypt(string data, out string decrypted)
		{
			bool result = Decrypt(Base64.GetBytes(data), out byte[] plain);
			decrypted = Encoding.UTF8.GetString(plain);
			return result;
		}

		/// <summary>
		/// 데이터에 서명합니다.
		/// </summary>
		/// <param name="data">서명할 데이터입니다.</param>
		/// <param name="type">서명에 사용할 해쉬함수를 지정합니다.</param>
		/// <returns>서명된 데이터입니다.</returns>
		public byte[] Sign(byte[] data, HashType type = HashType.SHA256)
		{
			try
			{
				service.FromXmlString(privateKey);

				byte[] sign;
				switch (type)
				{
					case HashType.SHA1:
					{
						sign = service.SignData(data, new SHA1CryptoServiceProvider());
						break;
					}
					case HashType.SHA256:
					{
						sign = service.SignData(data, new SHA256CryptoServiceProvider());
						break;
					}
					case HashType.SHA384:
					{
						sign = service.SignData(data, new SHA384CryptoServiceProvider());
						break;
					}
					case HashType.SHA512:
					{
						sign = service.SignData(data, new SHA512CryptoServiceProvider());
						break;
					}
					default:
					{
						sign = service.SignData(data, new SHA256CryptoServiceProvider());
						break;
					}
				}
				return sign;
			}
			catch { throw; }
		}
		/// <summary>
		/// 서명된 데이터를 검증합니다.
		/// </summary>
		/// <param name="data">서명의 유효성을 검증할 데이터를 지정합니다.</param>
		/// <param name="sign">데이터의 서명값을 지정합니다.</param>
		/// <param name="type">서명에 사용한 해쉬 알고리즘을 지정합니다.</param>
		/// <returns>검증 결과입니다.</returns>
		public bool Verify(byte[] data, byte[] sign, HashType type = HashType.SHA256)
		{
			try
			{
				service.FromXmlString(PublicKey);
				switch (type)
				{
					case HashType.SHA1:
					{
						return service.VerifyData(data, new SHA1CryptoServiceProvider(), sign);
					}
					case HashType.SHA256:
					{
						return service.VerifyData(data, new SHA256CryptoServiceProvider(), sign);
					}
					case HashType.SHA384:
					{
						return service.VerifyData(data, new SHA384CryptoServiceProvider(), sign);
					}
					case HashType.SHA512:
					{
						return service.VerifyData(data, new SHA512CryptoServiceProvider(), sign);
					}
					default:
					{
						return service.VerifyData(data, new SHA256CryptoServiceProvider(), sign);
					}
				};
			}
			catch { throw; }
		}
		/// <summary>
		/// 데이터에 서명합니다.
		/// </summary>
		/// <param name="data">서명할 데이터입니다.</param>
		/// <param name="type">서명에 사용할 해쉬함수를 지정합니다.</param>
		/// <returns>서명된 데이터입니다.</returns>
		public string Sign(string data, HashType type = HashType.SHA256)
		{
			return Base64.GetString(Sign(Encoding.UTF8.GetBytes(data), type));
		}
		/// <summary>
		/// 서명된 데이터를 검증합니다.
		/// </summary>
		/// <param name="data">서명의 유효성을 검증할 데이터를 지정합니다.</param>
		/// <param name="sign">데이터의 서명값을 지정합니다.</param>
		/// <param name="type">서명에 사용한 해쉬 알고리즘을 지정합니다.</param>
		/// <returns>검증 결과입니다.</returns>
		public bool Verify(string data, string sign, HashType type = HashType.SHA256)
		{
			return Verify(Encoding.UTF8.GetBytes(data), Base64.GetBytes(sign), type);
		}
		#region IDisposable Support
		private bool disposedValue = false;
		/// <summary>
		/// RSA 클래스를 제거합니다.
		/// </summary>
		~Rsa()
		{
			Dispose(false);
		}
		/// <summary>
		/// IDisposable 패턴을 구현합니다.
		/// </summary>
		/// <param name="disposing"></param>
		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					service?.Dispose();
				}
				PublicKey = string.Empty;
				privateKey = string.Empty;
				disposedValue = true;
			}
		}
		/// <summary>
		/// 클래스를 제거하고 리소스를 반환합니다.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		#endregion
	}
}