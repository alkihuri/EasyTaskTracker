# API Documentation

## Task Controller

### GetAll Tasks

- **URL**: `/api/tasks/getall`
- **Method**: `GET`
- **Description**: Получает список всех задач.
- **Response**: 
    - **Status Code**: `200 OK`
    - **Body**: Массив объектов задач.

### Get Task by ID

- **URL**: `/api/tasks/get/{id}`
- **Method**: `GET`
- **Description**: Получает задачу по идентификатору.
- **Parameters**:
    - `id` (integer): Идентификатор задачи.
- **Response**: 
    - **Status Code**: `200 OK`
    - **Body**: Объект задачи.

### Add Task

- **URL**: `/api/tasks/add`
- **Method**: `POST`
- **Description**: Добавляет новую задачу.
- **Request Body**: Объект задачи (JSON).
    ```json
    {
        "Name": "Task name",
        "Description": "Task description",
        "DueDate": "yyyy-MM-ddTHH:mm:ss",
        "AssignedUser": {
            "Name": "username",
            ...
        }
    }
    ```
- **Response**: 
    - **Status Code**: `200 OK`

### Delete Task

- **URL**: `/api/tasks/delete/{id}`
- **Method**: `GET`
- **Description**: Удаляет задачу по идентификатору.
- **Parameters**:
    - `id` (integer): Идентификатор задачи.
- **Response**: 
    - **Status Code**: `200 OK`

### Complete Task

- **URL**: `/api/tasks/complete/{id}`
- **Method**: `GET`
- **Description**: Помечает задачу с указанным идентификатором как завершенную.
- **Parameters**:
    - `id` (integer): Идентификатор задачи.
- **Response**: 
    - **Status Code**: `200 OK`

### Add Random Tasks

- **URL**: `/api/tasks/addrandom/{id}`
- **Method**: `GET`
- **Description**: Добавляет указанное количество случайных задач.
- **Parameters**:
    - `id` (integer): Количество задач для добавления.
- **Response**: 
    - **Status Code**: `200 OK`

# API Documentation

## Account Controller

### GetAll Accounts

- **URL**: `/api/account/getall`
- **Method**: `GET`
- **Description**: Получает список всех аккаунтов.
- **Response**: 
    - **Status Code**: `200 OK`
    - **Body**: Массив объектов пользователей.

### Get Account by Name

- **URL**: `/api/account/get/{name}`
- **Method**: `GET`
- **Description**: Получает аккаунт по имени.
- **Parameters**:
    - `name` (string): Имя пользователя.
- **Response**: 
    - **Status Code**: `200 OK`
    - **Body**: Объект пользователя.

### Register Account

- **URL**: `/api/account/register`
- **Method**: `POST`
- **Description**: Регистрирует новый аккаунт.
- **Request Body**: Объект пользователя (JSON).
    ```json
    {
        "Name": "example",
        "Email": "example@example.com",
        ...
    }
    ```
- **Response**: 
    - **Status Code**: `200 OK`
    - **Body**: Объект с информацией о зарегистрированном пользователе и его статусе верификации.
    ```json
    {
        "User": {
            "Name": "example",
            "Email": "example@example.com",
            ...
        },
        "IsVerified": true
    }
    ```

### Verify Account

- **URL**: `/api/account/verify`
- **Method**: `POST`
- **Description**: Проверяет верификацию аккаунта.
- **Request Body**: Объект пользователя (JSON).
    ```json
    {
        "Name": "example",
        ...
    }
    ```
- **Response**: 
    - **Status Code**: `200 OK`
    - **Body**: Статус верификации (true/false).
    ```json
    true
    ```
