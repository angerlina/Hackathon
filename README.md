# Hackathon SberTech 2016
Реализация REST-микросервисов генерации случайных тестовых данных.

Реализованы следующие сервисы:
* Генерация ИНН для юридических и физических лиц
* Генерация ОГРН для юридических лиц и ИП
* Генерация КПП
* Генерация СНИЛС
* Генерация кадастрового номера
* Генерация номера банковской карты
* Генерация Email
* Генерация типа населеного пункта
* Генерация воинского звания

Доступ к сервисам достигается по http-протоколу по определенным ссылкам.

На данный момент доступ к сервисам возможен только локально с веб-сервером приложений.

###Генерация номера ИНН
Для юридических лиц http://{host}:{port}/InnGeneratorService.svc/Generate/entity

Для физических лиц http://{host}:{port}/InnGeneratorService.svc/Generate/individual

###Генерация ОГРН
Для юридических лиц http://{host}:{port}/OGRNGeneratorService.svc/Generate/1

Для ИП http://{host}:{port}/OGRNGeneratorService.svc/Generate/2

###Генерация КПП
http://{host}:{port}/OGRNGeneratorService.svc/Generate/

###Генерация СНИЛС
http://{host}:{port}/SnilsGeneratorService.svc/Generate/

###Генерация кадастрового номера
http://{host}:{port}/CadastreGeneratorService.svc/Generate/

###Генерация номера банковской карты
http://{host}:{port}/CreditCardNumberGeneratorService.svc/Generate/

###Генерация Email по домену
http://{host}:{port}/EmailGeneratorService.svc/Generate/{domain}

Домен второго уровня указывается в виде любой строки.

###Генерация типа населенного пункта
http://{host}:{port}/LocalityTypeGeneratorService.svc/Generate/

###Генерация воинского звания
http://{host}:{port}/RankGeneratorService.svc/Generate/








