using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using MernisServiceReferance;
using MernisServiceReferance;

namespace Business.Concrete
{
    //Çıplak class kalmasın
    public class PersonManager : IApplicantService
    {
        //encapsulation
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthday)))
                .Result.Body.TCKimlikNoDogrulaResult;

        }

        public void ApplyFormask(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> Getlist()
        {
            throw new NotImplementedException();
        }
    }


}