using System;
using System.Text;

namespace BusinessLogic.Models
{
    public enum QualificationCategorie
    {
        HQC,
        FQC,
        WP,
        Not,
        none
    }

    public class Qualification
    {
        public DateTime Date { get; set; }
        public QualificationCategorie QualificationCategorie { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            switch (QualificationCategorie)
            {
                case QualificationCategorie.HQC:
                    sb.Append("ВКК ");
                    break;
                case QualificationCategorie.FQC:
                    sb.Append("1КК ");
                    break;
                case QualificationCategorie.WP:
                    sb.Append("СЗД ");
                    break;
                case QualificationCategorie.Not:
                    sb.Append("Нет ");
                    break;
                default:
                    break;
            }
            sb.Append(Date.ToString("dd.MM.yyyy"));
            return sb.ToString();
        }
    }

    
}