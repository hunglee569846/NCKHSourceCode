using EduSoft.core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EduSoft.core.Domain.IRepository
{
    public interface IBoMonRepository
    {
        Task<List<BoMonSearchViewModel>> SelectAllAsync();
    }
}
