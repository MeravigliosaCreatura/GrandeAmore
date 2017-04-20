using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Footballer
    {
        public long Id { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Прозвище")]
        public string Nickname { get; set; }
        public string Photo { get; set; }
        [DisplayName("Возраст")]
        public int Age { get; set; }
        [DisplayName("Рост")]
        public int Hight { get; set; }
        [DisplayName("Вес")]
        public int Weight { get; set; }
        [DisplayName("Позиция")]
        public string Position { get; set; }
        [DisplayName("Клуб")]
        public string FootballClub { get; set; }
        [DisplayName("Номер")]
        public int Number { get; set; }
        [DisplayName("Страна")]
        public string Country { get; set; }


    }
}