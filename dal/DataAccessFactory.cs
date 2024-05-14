using dal.interfaces;
using dal.models;
using dal.repos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class DataAccessFactory
    {
        public static IRepo<announcement, int, announcement> AnnouncementData()
        {
            return new announcementRepo();
        }

        public static IRepo<comment, int, comment> CommentData()
        {
            return new commentsRepo();
        }

        public static IRepo<report, int, report> ReportData()
        {
            return new reportRepo();
        }

        public static IRepo<rule,int, rule> RuleData()
        {
            return new ruleRepo();
        }


    }
}
