namespace ClassLibrary2
{
    // Основной класс библиотеки
    public class Class1
    {
        // Класс, представляющий заявку на ремонт
        public class Program
        {
            // Уникальный идентификатор заявки
            public int Id { get; set; }
            // Тип оборудования, требующего ремонта
            public string Equipmen { get; set; }
            // Серийный номер оборудования
            public string Number { get; set; }
            // Описание проблемы с оборудованием
            public string Description { get; set; }
            // Идентификатор клиента, подавшего заявку
            public string ClientId { get; set; }
            // Приоритет заявки (например, высокий, средний, низкий)
            public string Pririty { get; set; }
            // Дата и время создания заявки
            public DateTime Create { get; set; }
            // Дата и время последнего обновления заявки
            public DateTime Update { get; set; }
            // Дата и время завершения выполнения заявки
            public DateTime Finish { get; set; }
            // Статус заявки (например, новая, в обработке, завершена)
            public string Status { get; set; }
        }

        // Класс, представляющий исполнителя заявки
        public class Ispolnitel
        {
            // Уникальный идентификатор исполнителя
            public int Id { get; set; }
        }

        // Класс, представляющий клиента
        public class Client
        {
            // Уникальный идентификатор клиента
            public int Id { get; set; }
        }

        // Класс для представления заявки на ремонт с параметрами конструктора
        public class RequestRemont(int id, int ClientId)
        {
            // Уникальный идентификатор заявки
            public int Id { get; set; }
            // Тип оборудования, требующего ремонта
            public string Equipmen { get; set; }
            // Серийный номер оборудования
            public string Number { get; set; }
            // Описание проблемы с оборудованием
            public string Description { get; set; }
            // Идентификатор клиента, подавшего заявку
            public string ClientId { get; set; }
            // Приоритет заявки (например, высокий, средний, низкий)
            public string Pririty { get; set; }
            // Дата и время создания заявки
            public DateTime Create { get; set; }
            // Дата и время последнего обновления заявки
            public DateTime Update { get; set; }
            // Дата и время завершения выполнения заявки
            public DateTime Finish { get; set; }
            // Статус заявки (например, новая, в обработке, завершена)
            public string Status { get; set; }
        }

        // Класс для регистрации заявки на ремонт
        public class RegZayavki
        {
            // Уникальный идентификатор регистрации заявки
            public int Id { get; set; }
            // Приоритет заявки (например, высокий, средний, низкий)
            public string Priority { get; set; }
            // Описание проблемы с оборудованием
            public string Description { get; set; }
            // Идентификатор клиента, подавшего заявку
            public string ClientId { get; set; }
            // Тип оборудования, требующего ремонта
            public string Equipmen { get; set; }
        }

        // Класс для обработки заявки на ремонт
        public class ObrabZayavki
        {
            // Уникальный идентификатор обработки заявки
            public int Id { get; set; }
            // Приоритет обработки заявки (например, высокий, средний, низкий)
            public string Priority { get; set; }
            // Идентификатор исполнителя, назначенного на выполнение заявки
            public string IdIspolnitel { get; set; }
            // Идентификатор клиента, подавшего заявку
            public string ClientId { get; set; }
            // Дополнительные детали по заявке или проблеме
            public string Details { get; set; }
            // Тип оборудования, требующего ремонта
            public string Equipmen { get; set; }
        }

        // Класс для исполнения заявки на ремонт оборудования
        public class IspolnenieZayavki
        {
            // Уникальный идентификатор исполнения заявки
            public int Id { get; set; }
            // Идентификатор клиента, подавшего заявку 
            public string ClientId { get; set; }
            // Запчасти использованные в ремонте 
            public string Spareparte { get; set; }
            // Идентификатор исполнителя 
            public string IdIspolnitel { get; set; }
            // Тип оборудования 
            public string Equipmen { get; set; }
        }

        // Класс для отчета о выполненной работе по заявке на ремонт 
        public class Otchet
        {
            // Уникальный идентификатор отчета 
            public int Id { get; set; }
            // Идентификатор клиента 
            public string ClientId { get; set; }
            // Приоритет работы 
            public string Priority { get; set; }
            // Время затраченное на выполнение работы 
            public string Time { get; set; }
            // Тип оборудования 
            public string Equipment { get; set; }
            // Идентификатор исполнителя 
            public string IdIspolnitel { get; set; }
            // Запчасти использованные в ремонте 
            public string Sparepartey { get; set; }
            // Стоимость выполненных работ 
            public string Cost { get; set; }
        }

        // Класс для мониторинга и анализа работы по заявкам на ремонт 
        public class MonitoringAnalyz
        {
            // Уникальный идентификатор анализа 
            public int Id { get; set; }
            // Идентификатор клиента 
            public string ClientId { get; set; }
            // Расходы по заявкам на ремонт 
            public string Expenses { get; set; }
            // Качество выполненных работ 
            public string Quality { get; set; }
            // Время затраченное на выполнение работ 
            public string Time { get; set; }
            // Приоритет работы 
            public string Priority { get; set; }
        }
    }
}