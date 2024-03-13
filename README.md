# Сервис для занятия с  репетиторами
# 16 Команда
    Григорьев Алексей
    Космач Мария
    Скирляк Ярослав
    Таипов Тимур
    Фролова Кристина


# Сущность пользователя
    "user_id": "123",
    "full_name": "Ivan Ivanov",
    "phone": "+7 --- --- -- --",
    "mail": "asf@asf.ru",
    "avatar": "url",
    "login": "vanyaklass2008",
    "password_hashed": "asflhkj;lJKKKSF9283"
    "role": "student",

## Методы
### Создание пользователя - POST api/v1/users/createuser
    request - {
        "full_name": "Тестовый пользователь",
        "phone": "+7 --- --- -- --",
        "mail": "asf@asf.ru",
        "avatar": "url",
        "login": "vanyaklass2008",
        "password_hashed": "asflhkj;lJKKKSF9283"
        "role": "student",
    }
    response - {
        "body": true,
        "errors": ["string"]
    }
### Получение пользователя - GET api/v1/users/getuser?id
    request - {
        "user_id": "124"
    }
    response - {
        "user_id": "124"
        "full_name": "Тестовый пользователь",
        "phone": "+7 --- --- -- --",
        "mail": "asf@asf.ru",
        "avatar": "url",
        "login": "vanyaklass2008",
        "role": "student",
    }
### Изменение пользователя - UPDATE api/v1/users/updateuser?id
    request - {
        "user_id": "124",
        "request_body": []
    }
    response - {
        "body": true,
        "errors": ["string"]
    }
### Удаление пользователя - DELETE api/v1/users/deleteuser?id
    request - {
        "user_id": "124",
    }
    response - {
        "body": true,
        "errors": ["string"]
    }

# Тема:
    "theme_id": "12412",
    "title": "vectors",
    "difficulty": "3"

### Создание темы - POST api/v1/themes/createtheme
    request - {
        "title": "vectors",
        "difficulty": "3"
    }
    response - {
        "body": true,
        "errors": ["string"]
    }
### Получение темы - GET api/v1/themes/gettheme?id
    request - {
        "theme_id": "124"
    }
    response - {
        "theme_id": "124"
        "title": "vectors пользователь",
        "difficulty": "3",
    }

### Изменение темы - UPDATE api/v1/themes/updatetheme?id
    request - {
        "theme_id": "124",
        "request_body": []
    }
    response - {
        "body": true,
        "errors": ["string"]
    }
### Удаление темы - DELETE api/v1/themes/deletetheme?id
    request - {
        "theme_id": "124",
    }
    response - {
        "body": true,
        "errors": ["string"]
    }

# Ученик на теме:
    "student_id": "123",
    "user_id": "124",
    "tutor_user_id": "124",
    "theme_id": "12",
    "completed_tasks": { 1, 2, 3, 4 },
    "suggested_tasksЭ: { 1, 2, 3, 4, 5 }

### Создание ученика на теме - POST api/v1/students/createstudent
    request - {
        "user_id": "1234",
        "tutor_user_id": "124",
        "theme_id": "12",
        "completed_tasks": { 1, 2, 3, 4 },
        "suggested_tasks: { 1, 2, 3, 4, 5 }
    }
    response - {
        "body": true,
        "errors": ["string"]
    }

### Получение ученика на теме - GET api/v1/students/getstudent?id
    request - {
        "student_id": "124"
    }
    response - {
        "student_id": "124",
        "user_id": "124",
        "tutor_user_id": "124",
        "theme_id": "124",
        "completed_tasks": { 1, 2, 3, 4 },
        "suggested_tasks": { 1, 2, 3, 4, 5 }
    }

### Изменение ученика на теме - UPDATE api/v1/students/updatestudent?id
    request - {
        "student_id": "124",
        "request_body": []
    }
    response - {
        "body": true,
        "errors": ["string"]
    }
### Удаление ученика на теме- DELETE api/v1/students/deletestudent?id
    request - {
        "theme_id": "124",
    }
    response - {
        "body": true,
        "errors": ["string"]
    }


# Задание
    "task_id": "124",
    "name": "Сложение",
    "description": "2+2",
    "difficulty": "3",

### Создание задания - POST api/v1/tasks/createtask
    request - {
        "name": "Сложение",
        "description": "2+2",
        "difficulty": "3",
    }
    response - {
        "body": true,
        "errors": ["string"]
    }

### Получение задания - GET api/v1/tasks/gettasks?id
    request - {
        "task_id": "124"
    }
    response - {
        "task_id": "124",
        "name": "Сложение",
        "description": "2+2",
        "difficulty": "3",
    }

### Изменение задания - UPDATE api/v1/tasks/updatetask?id
    request - {
        "task_id": "124",
        "request_body": []
    }
    response - {
        "body": true,
        "errors": ["string"]
    }
### Удаление задания - DELETE api/v1/tasks/deletetask?id
    request - {
        "theme_id": "124",
    }
    response - {
        "body": true,
        "errors": ["string"]
    }

# Задание темы
    "task_theme_id": "124",
    "task_id": "1",
    "theme_id": "2"

### Создание задания темы - POST api/v1/tasks/createthemetask
    request - {
        "task_id": "1",
        "theme_id": "2",
    }
    response - {
        "body": true,
        "errors": ["string"]
    }

### Получение задания - GET api/v1/tasks/getthemetask?id
    request - {
        "task_theme_id": "124"
    }
    response - {
        "task_theme_id": "124",
        "task_id": "1",
        "theme_id": "2"
    }

### Изменение задания - UPDATE api/v1/tasks/updatethemetask?id
    request - {
        "task_theme_id": "124",
        "request_body": []
    }
    response - {
        "body": true,
        "errors": ["string"]
    }
### Удаление задания - DELETE api/v1/tasks/deletethemetask?id
    request - {
        "task_theme_id": "124",
    }
    response - {
        "body": true,
        "errors": ["string"]
    }
 
   