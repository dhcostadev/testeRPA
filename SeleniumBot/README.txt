Instruções
- Instalar Visual Studio versão 2022
- Instalar Postgresql versão 8.2
- Criar Server no PgAdmin 4 com o nome selenium
- Criar Database no PgAdmin 4 com o nome automation
- Criar Tabela no PgAdmin 4 com o nome result, com os campos wpm (char), keystrokes (int), accuracy (char), correct_words (int), wrong_words (int);

Gerenciador de Pacote Nuget
- Instalar Web Driver Selenium mais atual
- Google Chrome versão 122.0.6261.96
- Instalar o Npgsql (para conectar com o Banco)
- Instalar o Dapper (para executar os comandos e realizar consultas)

Sobre execução
- Apertar o Start
- Após o carregamento do site, o robo iniciará escrevendo as informações e inserindo no campo de input. Foi inserido propositalmente alguns erros na hora da escrita das palavras no input para que de fato fosse inserido o contador de erros na tabela wrongWords