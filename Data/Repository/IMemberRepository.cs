using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();

        Member GetMemberByEmail(string email);

        void UpdateMember(Member member);

        void DeleteMember(string email);

        void CreateMember(Member member);
    }
}