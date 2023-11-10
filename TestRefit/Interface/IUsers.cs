using System;
using Refit;
using TestRefit.Model;

namespace TestRefit.Interface
{
	public interface IUsers
	{
        [Get("/users")]
        Task<IEnumerable<User>> GetAll();
    }
}

