# Benchmark Tests

Repositório com projetos de testes de benchmark para verificar consumo e performance entre algumas tecnologias para .NET.

## ⚙️ Configuração

Para configurar o ambiente de testes, siga o passo abaixo:

1. **Configurar o .NET 8**
   - Certifique-se de ter o [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) instalado.
   - Para verificar a instalação, execute:
     ```sh
     dotnet --version
     ```

## 🛠️ Baixar projeto e rodar testes

1. **Baixar o projeto**
   - Clone o repositório utilizando o comando:
     ```sh
     git clone https://github.com/diegoferreirax/dotnet-benchmark-tests.git
     ```
   - Alternativamente, faça o download do código-fonte manualmente e extraia os arquivos.

2. **Rodar o projeto**
   - No mesmo diretório atual, entre no projeto de benchmarks:
     ```sh
     cd dotnet-benchmark-tests\src
     ```
   - Execute os seguintes comandos para buildar o projeto em modo release:
      ```sh
      dotnet restore
      dotnet build -c Release
      ``` 
   - Execute o comando RUN apontando para o projeto que deseja executar os testes:
      ```sh
      dotnet run -c Release --project FluentValidationVsCSharpExtensions
      ```

---

## 📚 Visualizando os resultados

1. **Acessar pasta de artifacts (somente rodando localmente)**
   - No diretório `BenchmarkDotNet.Artifacts` é possivel visualizar os resultados em texto e HTML.

2. **Acessar o print na pasta do projeto de teste**
   - Em cada projeto há um print aplicado manualmente do último teste realizado.    
   Exemplo: `dotnet-benchmark-tests\FluentValidationVsCSharpExtensions\result.png`
