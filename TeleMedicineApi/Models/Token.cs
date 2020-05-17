using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TeleMedicineApi.Models
{
    public class Token
    {
        public static Token Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                        _instance = new Token();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Checks and deletes all expired token from token-store
        /// </summary>
        public void CleanUp()
        {
            for (int i = Token.Instance.lstUserToken.Count - 1; i > -1; i--)
            {
                if (Token.Instance.lstUserToken[i].ExpiresOn < DateTime.Now)
                    Token.Instance.lstUserToken.RemoveAt(i);
            }
        }
        /// <summary>
        ///  List of user Toke Info
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public TokenEntity Generate(string userid)
        {
            lock (LockObj)
            {
                Guid token = Guid.NewGuid();
                TokenEntity tokenEntity = new TokenEntity()
                {
                    TokenId = token,
                    IssuedOn = DateTime.Now,
                    ExpiresOn = DateTime.Now.AddSeconds(Convert.ToDouble(ConfigurationManager.AppSettings["TokenDuration"])),
                    UserId = userid
                };
                lstUserToken.Add(tokenEntity);
                return tokenEntity;
            }

        }
        /// <summary>
        /// To increase the time of the token whenever a valid request comes with a valid 
        /// </summary>
        /// <param name="tokenId"></param>
        /// <returns></returns>
        public string Extend(Guid tokenId)
        {
            lock (LockObj)
            {
                int i = TokenIndex(tokenId, true);
                if (i < 0) return string.Empty;
                Token.Instance.lstUserToken[i].ExpiresOn = Token.Instance.lstUserToken[i].ExpiresOn.AddSeconds(Convert.ToDouble(ConfigurationManager.AppSettings["TokenDuration"]));
                return Token.Instance.lstUserToken[i].UserId;
            }
        }


        #region private 
        static Token _instance;
        List<TokenEntity> lstUserToken = new List<TokenEntity>();
        private static object LockObj = new Object();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="ignoreExpiry"></param>
        /// <returns></returns>
        private int TokenIndex(Guid tokenId, bool ignoreExpiry)
        {
            TokenEntity tokenEntity = Token.Instance.lstUserToken.Find(x => x.TokenId == tokenId);
            if (tokenEntity == null)
                return -1;

            if ((!ignoreExpiry) && (tokenEntity.ExpiresOn < DateTime.Now))
                return -1;

            return Token.Instance.lstUserToken.IndexOf(tokenEntity);
        }
        #endregion private 
    }
}