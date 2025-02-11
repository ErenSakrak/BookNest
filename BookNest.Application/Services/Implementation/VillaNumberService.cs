using BookNest.Application.Common.Interfaces;
using BookNest.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookNest.Application.Common.Interfaces;
using BookNest.Application.Services.Interface;
using BookNest.Domain.Entities;

namespace BookNest.Application.Services.Implementation
{
    public class VillaNumberService : IVillaNumberService
    {
        private readonly IUnitOfWork _unitOfWork;

        public VillaNumberService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool CheckVillaNumberExists(int villa_Number)
        {
            return _unitOfWork.VillaNumber.Any(u => u.Villa_number == villa_Number);
        }

        public void CreateVillaNumber(VillaNumber villaNumber)
        {
            _unitOfWork.VillaNumber.Add(villaNumber);
            _unitOfWork.Save();
        }

        public bool DeleteVillaNumber(int id)
        {
            try
            {
                VillaNumber? objFromDb = _unitOfWork.VillaNumber.Get(u => u.Villa_number == id);
                if (objFromDb is not null)
                {
                    _unitOfWork.VillaNumber.Remove(objFromDb);
                    _unitOfWork.Save();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<VillaNumber> GetAllVillaNumbers()
        {
            return _unitOfWork.VillaNumber.GetAll(includeProperties: "Villa");
        }

        public VillaNumber GetVillaNumberById(int id)
        {
            return _unitOfWork.VillaNumber.Get(u => u.Villa_number == id, includeProperties: "Villa");
        }

        public void UpdateVillaNumber(VillaNumber villaNumber)
        {
            _unitOfWork.VillaNumber.Update(villaNumber);
            _unitOfWork.Save();
        }
    }
}