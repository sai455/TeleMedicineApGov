﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeleMedicineDAL.DataContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TeleMedicineEntities : DbContext
    {
        public TeleMedicineEntities()
            : base("name=TeleMedicineEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int GEMASTER_INVESTIGATION_CATEGORYS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GEMASTER_INVESTIGATION_CATEGORYS");
        }
    
        public virtual ObjectResult<GETCALLERDETAILS_Result> GETCALLERDETAILS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETCALLERDETAILS_Result>("GETCALLERDETAILS");
        }
    
        public virtual int GETDIAGNOSISS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GETDIAGNOSISS");
        }
    
        public virtual ObjectResult<GETDISTRICTS_Result> GETDISTRICTS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETDISTRICTS_Result>("GETDISTRICTS");
        }
    
        public virtual int GETMASTER_DRUG_DOSAGES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GETMASTER_DRUG_DOSAGES");
        }
    
        public virtual int GETMASTER_DRUG_FORMS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GETMASTER_DRUG_FORMS");
        }
    
        public virtual int GETMASTER_DRUG_INSTRUCTIONS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GETMASTER_DRUG_INSTRUCTIONS");
        }
    
        public virtual ObjectResult<GETMASTER_INVESTIGATION_GROUPS_Result> GETMASTER_INVESTIGATION_GROUPS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETMASTER_INVESTIGATION_GROUPS_Result>("GETMASTER_INVESTIGATION_GROUPS");
        }
    
        public virtual int GETMASTER_INVESTIGATIONS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GETMASTER_INVESTIGATIONS");
        }
    
        public virtual ObjectResult<GETMASTER_MEDICINE_DRUG_CLASS_Result> GETMASTER_MEDICINE_DRUG_CLASS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETMASTER_MEDICINE_DRUG_CLASS_Result>("GETMASTER_MEDICINE_DRUG_CLASS");
        }
    
        public virtual ObjectResult<GETMASTER_MENUS_Result> GETMASTER_MENUS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETMASTER_MENUS_Result>("GETMASTER_MENUS");
        }
    
        public virtual ObjectResult<GETMASTER_PRODUCTS_Result> GETMASTER_PRODUCTS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETMASTER_PRODUCTS_Result>("GETMASTER_PRODUCTS");
        }
    
        public virtual ObjectResult<GETMASTER_SPECIALITYS_Result> GETMASTER_SPECIALITYS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETMASTER_SPECIALITYS_Result>("GETMASTER_SPECIALITYS");
        }
    
        public virtual int GETMASTER_STATES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GETMASTER_STATES");
        }
    
        public virtual ObjectResult<GETMASTER_SYMPTOMS_Result> GETMASTER_SYMPTOMS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETMASTER_SYMPTOMS_Result>("GETMASTER_SYMPTOMS");
        }
    
        public virtual ObjectResult<GETMASTER_USERS_Result> GETMASTER_USERS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETMASTER_USERS_Result>("GETMASTER_USERS");
        }
    
        public virtual ObjectResult<GETMENU_USER_PERMISSIONS_Result> GETMENU_USER_PERMISSIONS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETMENU_USER_PERMISSIONS_Result>("GETMENU_USER_PERMISSIONS");
        }
    
        public virtual ObjectResult<GETPATIENT_BASIC_DETAILS_Result> GETPATIENT_BASIC_DETAILS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETPATIENT_BASIC_DETAILS_Result>("GETPATIENT_BASIC_DETAILS");
        }
    
        public virtual ObjectResult<GETPATIENT_CALLER_HISTORYS_Result> GETPATIENT_CALLER_HISTORYS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETPATIENT_CALLER_HISTORYS_Result>("GETPATIENT_CALLER_HISTORYS");
        }
    
        public virtual ObjectResult<GETPATIENT_DIAGNOSIS_DETAILS_Result> GETPATIENT_DIAGNOSIS_DETAILS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETPATIENT_DIAGNOSIS_DETAILS_Result>("GETPATIENT_DIAGNOSIS_DETAILS");
        }
    
        public virtual ObjectResult<GETPATIENT_DOCTOR_NOTES_Result> GETPATIENT_DOCTOR_NOTES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETPATIENT_DOCTOR_NOTES_Result>("GETPATIENT_DOCTOR_NOTES");
        }
    
        public virtual ObjectResult<GETPATIENT_INSTRUCTION_DETAILS_Result> GETPATIENT_INSTRUCTION_DETAILS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETPATIENT_INSTRUCTION_DETAILS_Result>("GETPATIENT_INSTRUCTION_DETAILS");
        }
    
        public virtual ObjectResult<GETPATIENT_INVESTIGATION_DETAILS_Result> GETPATIENT_INVESTIGATION_DETAILS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETPATIENT_INVESTIGATION_DETAILS_Result>("GETPATIENT_INVESTIGATION_DETAILS");
        }
    
        public virtual ObjectResult<GETPATIENT_SYMPTOMS_Result> GETPATIENT_SYMPTOMS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETPATIENT_SYMPTOMS_Result>("GETPATIENT_SYMPTOMS");
        }
    
        public virtual ObjectResult<GETUSER_LOG_Result> GETUSER_LOG()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETUSER_LOG_Result>("GETUSER_LOG");
        }
    
        public virtual ObjectResult<GETUSERDESIGATIONDATABYUSERID_Result> GETUSERDESIGATIONDATABYUSERID(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETUSERDESIGATIONDATABYUSERID_Result>("GETUSERDESIGATIONDATABYUSERID", userIDParameter);
        }
    
        public virtual ObjectResult<GETVILLAGES_Result> GETVILLAGES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETVILLAGES_Result>("GETVILLAGES");
        }
    
        public virtual ObjectResult<VALIDATEUSER_Result> VALIDATEUSER(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VALIDATEUSER_Result>("VALIDATEUSER", userNameParameter, passwordParameter);
        }
    }
}