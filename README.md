Clone o repositório

     git@github.com:yurisalgado21/ClientManagementAPIDB.git

No desenvolvimento, este projeto possui um arquivo do docker compose para subir um serviço do banco de dados Azure Data Studio o qual eu utilizei. Este banco de dados possui a mesma arquitetura do SQL Server.

Para subir o serviço, utilize o comando:

    docker-compose up -d --build

Para conectar ao seu sistema de gerenciamento de banco de dados, utilize as seguintes credenciais:

    Server: localhost
    User: sa
    Password: Password123
    Trust server certificate: true
