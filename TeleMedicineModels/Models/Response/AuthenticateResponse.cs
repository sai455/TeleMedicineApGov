﻿namespace TeleMedicineModels.Models.Response
{
    public class AuthenticateResponse
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
