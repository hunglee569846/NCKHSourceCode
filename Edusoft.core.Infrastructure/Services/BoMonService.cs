using EduSoft.core.Domain.IRepository;
using EduSoft.core.Domain.IServices;
using EduSoft.core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Edusoft.core.Infrastructure.Services
{
    public class BoMonService : IBoMonService
    {
        private readonly IBoMonRepository _IBoMonRepository;
        private readonly IKhoaRepository _IKhoaRepository;
        public BoMonService(IKhoaRepository khoaRepository,IBoMonRepository boMonRepository)
        {
            _IKhoaRepository = khoaRepository;
            _IBoMonRepository = boMonRepository;

        }
        public async Task<List<BoMonSearchViewModel>> SelecAllAsync()
        {
            return await _IBoMonRepository.SelectAllAsync();
        }
    }
}
