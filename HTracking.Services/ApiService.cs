using System;
using System.Collections.Generic;
using HTracking.Data;
using HTracking.Models;

namespace HTracking.Services
{
    public interface IApiService 
    {
        IList<BaseForm> GetForms();
        void SubmitForm(BaseForm form);
    }

    public class ApiService : IApiService
    {
        readonly IDataService _dataService;

        public ApiService(IDataService dataService)
        {
            _dataService = dataService;
        }

        public IList<BaseForm> GetForms()
        {
            return _dataService.GetForms();
        }

        public void SubmitForm(BaseForm form)
        {
            _dataService.SubmitForm(form);
        }
    }
}
