using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void CreateMember(Member member)
        {
            AppDBContext.Instance.Members.Add(member);
            AppDBContext.Instance.SaveChanges();
        }

        public void DeleteMember(string email)
        {
            var member = GetMemberByEmail(email);
            AppDBContext.Instance.Members.Remove(member);
            AppDBContext.Instance.SaveChanges();
        }

        public Member GetMemberByEmail(string email) => AppDBContext.Instance.Members.Where(member => member.Email == email).SingleOrDefault();

        public IEnumerable<Member> GetMembers() => AppDBContext.Instance.Members.ToList();

        public void UpdateMember(Member member)
        {
            AppDBContext.Instance.Members.Update(member);
            AppDBContext.Instance.SaveChanges();
        }
    }
}