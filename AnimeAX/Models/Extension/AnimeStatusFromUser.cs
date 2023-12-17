namespace AnimeAX.Models.DataBase
{
    partial class AnimeStatusFromUser
    {
        public string AnimeStatusGroup
        {
            get
            {
                if (StatusId == 1)
                    return "Просмотрено";
                else if (StatusId == 2)
                    return "Брошено";
                else if (StatusId == 3)
                    return "Отложено";
                else if (StatusId == 4)
                    return "Запланировано";
                else if (StatusId == 5)
                    return "Пересмотрено";
                else if (StatusId == 6)
                    return "Смотрю";
                else
                    return "Не приятно";
            }
        }
    }
}
