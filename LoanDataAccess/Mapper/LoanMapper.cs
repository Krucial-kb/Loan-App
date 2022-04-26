using LoanDataAccess.DbModels;
using LoanDomain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDataAccess.Mapper
{
    public class LoanMapper
    {
        #region ----- Data Access to Domain -----

        public static Demographic MapApplicantDAL(DemographicDomain _applicant)
        {
            return _applicant is null ? null : new Demographic
            {
                Id = _applicant.Id,
                FirstName = _applicant.FirstName,
                LastName = _applicant.LastName,
                Email = _applicant.Email,
                UserName = _applicant.UserName,
            };
        }

        public static Business MapBusinessDAL(BusinessDomain _business)
        {
            return _business is null ? null : new Business
            {
                Id = _business.Id,
                BusinessName = _business.BusinessName,
                Address = _business.Address,
                City = _business.City,
                State = _business.State,
                ZipCode = _business.ZipCode,
                Country = _business.Country,
                ApplicantId = _business.ApplicantId,
            };
        }

        public static Loan MapLoansDAL(LoansDomain _loans)
        {
            return _loans is null ? null : new Loan
            {
                Id = _loans.Id,
                CreditScore = _loans.CreditScore,
                ApplicantId = _loans.ApplicantId,
                Apr = _loans.Apr,
                RequestedAmount = _loans.RequestedAmount,
                LatePayments = _loans.LatePayments,
                PaybackTime = _loans.PaybackTime,
                RiskRating = _loans.RiskRating,
                TotalDebt = _loans.TotalDebt,
            };
        }

        #endregion

        #region ----- Domain to Data Access -----
        public static DemographicDomain MapApplicantDOM(Demographic _applicant)
        {
            return _applicant is null ? null : new DemographicDomain
            {
                Id = _applicant.Id,
                FirstName = _applicant.FirstName,
                LastName = _applicant.LastName,
                Email = _applicant.Email,
                UserName = _applicant.UserName,
            };
        }

        public static BusinessDomain MapBusinessDOM(Business _business)
        {
            return _business is null ? null : new BusinessDomain
            {
                Id = _business.Id,
                BusinessName = _business.BusinessName,
                Address = _business.Address,
                City = _business.City,
                State = _business.State,
                ZipCode = _business.ZipCode,
                Country = _business.Country,
                ApplicantId = _business.ApplicantId,
            };
        }

        public static LoansDomain MapLoansDOM(Loan _loans)
        {
            return _loans is null ? null : new LoansDomain
            {
                Id = _loans.Id,
                CreditScore = _loans.CreditScore,
                ApplicantId = _loans.ApplicantId,
                Apr = _loans.Apr,
                RequestedAmount = _loans.RequestedAmount,
                LatePayments = _loans.LatePayments,
                PaybackTime = _loans.PaybackTime,
                RiskRating = _loans.RiskRating,
                TotalDebt = _loans.TotalDebt,
            };
        }

        #endregion
    }
}
