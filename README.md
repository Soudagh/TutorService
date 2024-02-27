# Сущность пользователя
    "user_id": "123",
    "full_name": "Ivan Ivanov",
    "phone": "+7 --- --- -- --",
    "mail": "asf@asf.ru",
    "avatar": "url",
    "login": "vanyaklass2008",
    "password_hashed": "asflhkj;lJKKKSF9283"
    "role": "pupil",

## Методы
### Создание пользователя - POST api/v1/users/createuser
    request - {
        "full_name": "Тестовый пользователь",
        "phone": "+7 --- --- -- --",
        "mail": "asf@asf.ru",
        "avatar": "url",
        "login": "vanyaklass2008",
        "password_hashed": "asflhkj;lJKKKSF9283"
        "role": "pupil",
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
        "role": "pupil",
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

# Сущность ученика: 
    "pupil_id": "123",
    "user_id": "124",
    "grade": "8",
    "full_name_parent": "Maria Ivanova",
    "contact_parent": "+7 --- --- -- --",
### Создание ученика - POST api/v1/pupils/createpupil
    request - {
        "user_id": "124",
        "grade": "8",
        "full_name_parent": "Maria Ivanova",
        "contact_parent": "+7 --- --- -- --",
    }
    response - {
        "body": true,
        "errors": ["string"]
    }

### Получение ученика - GET api/v1/pupils/getpupil?1
    request - {
        "pupil_id": "124"
    }
    response - {
        "user_id": "124",
        "grade": "8",
        "full_name_parent": "Maria Ivanova",
        "contact_parent": "+7 --- --- -- --",
    }
### Изменение ученика - UPDATE api/v1/pupils/updatepupil?1
    request - {
        "pupil_id": "124",
        "request_body": []
    }
    response - {
        "body": true,
        "errors": ["string"]
    }
### Удаление ученика - DELETE api/v1/pupils/deletepupil?id
    request - {
        "pupil_id": "124",
    }
    response - {
        "body": true,
        "errors": ["string"]
    }


# Сущность репетитора:
    "tutor_id": "123",
    "user_id": "125",
    "subjects": "linear algebra, geometry",
    "date_start_teaching": "20.02.2002",
    "place": "SPB52"

### Создание репетитора - POST api/v1/tutors/createtutor
    request - {
        "user_id": "124",
        "subjects": "linear algebra, geometry",
        "date_start_teaching": "20.02.2002",
        "place": "SPB52"
    }
    response - {
        "body": true,
        "errors": ["string"]
    }

### Получение репетитора - GET api/v1/tutors/gettutor?1
    request - {
        "tutor_id": "124"
    }
    response - {
        "user_id": "124",
        "pupil_id": "124"
        "subjects": "linear algebra, geometry",
        "date_start_teaching": "20.02.2002",
        "place": "SPB52",
    }

### Изменение репетитора - UPDATE api/v1/tutors/updatetutor?1
    request - {
         "tutor_id": "124"
        "request_body": []
    }
    response - {
        "body": true,
        "errors": ["string"]
    }
### Удаление репетитора- DELETE api/v1/tutors/deletetutor?id
    request - {
         "tutor_id": "124"
    }
    response - {
        "body": true,
        "errors": ["string"]
    }

# Тема:
    "theme_id": "12412",
    "title": "vectors",
    "difficulty": "3"

# Ученик на теме:
    "pupil_theme_id": "123",
    "pupil_id": "124",
    "tutor_id": "124",
    "theme_id": "12",
    "completed_tasks": "1, 2, 3, 4",
    "suggested_tasks: "1, 2, 3, 4, 5"

# Задание
    "task_id": "124",
    "name": "Сложение",
    "description": "2+2",
    "difficulty": "3",
    "themes": "1, 2, 3, 4",
 
   