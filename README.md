# Cheat_VIP 

Uma ferramenta de manipulação de memória desenvolvida em **C#** para modificar intruções e comportamentos de processos em tempo real.  

---

## Funcionalidades  

-  **Anexar a Processos**: Conecte-se a um processo em execução para manipular sua memória.  
-  **Substituição de Instruções**: Modifique códigos assembly em tempo real.  
-  **Injeção de Código**: Insira instruções personalizadas diretamente na memória do processo.  
-  **Autenticação via Pastebin**: Libere funcionalidades com credenciais do Pastebin.  
-  **Interface Gráfica**: Interface intuitiva para facilitar a manipulação.  

---

## **Pré-requisitos**  

- **.NET 8.0**  
- **Windows**  
- **Pastebin API Key** (para autenticação)  
- **Permissões de Administrador** (para manipular memória de processos)  

---

## **Como Usar**  

### 1. **Configuração**  
Clone o repositório:  

```bash
git clone https://github.com/victorhugoscf/Cheat_VIP.git
```

Abra o projeto no **Visual Studio** e configure a chave de API no arquivo `PastebinAuth.cs`:  

```csharp
private const string PastebinApiKey = "SUA_CHAVE_DE_API_AQUI";
```

### 2. **Executando o Projeto**  
1 Compile o projeto no **Visual Studio**.  
2 Execute o aplicativo como **administrador**.  
3 Faça login com suas credenciais do **Pastebin**.  
4 Anexe-se a um processo e comece a manipular a memória.  

---

## **Exemplos de Uso**  

###  **Substituir uma Instrução**  
Para substituir uma instrução assembly, use:  

```csharp
memoryPatcher.ReplaceInstruction(address, valor, "eax", 5, 1); // Substitui 5 bytes e preenche 1 byte com NOP
```

### **Restaurar o Código Original**  
Caso precise restaurar o código original:  

```csharp
byte[] originalCode = new byte[] { 0x8B, 0x8D, 0x24, 0xFF, 0xFF, 0xFF }; // Código original
memoryPatcher.RestoreOriginalCode(address, originalCode);
```

---

## **Interface Gráfica**  

- **Aba de Processos**: Liste e anexe-se a processos em execução.  
- **Aba de Cheats**: Ative/desative hacks e modifique valores em tempo real.  
- **Autenticação**: Faça login via **Pastebin**.  

 **Veja um exemplo da interface abaixo:**  

![Interface Gráfica](interface.gif)


---

## **Estrutura do Projeto**  

 **Arquivos principais:**  

```
Cheat_VIP/
¦-- src/
¦   +-- Form1.cs            # Interface gráfica principal
¦   +-- MemoryPatcher.cs    # Lógica de manipulação de memória
¦   +-- MemoryManager.cs    # Gerenciamento da conexão com o processo
¦   +-- PastebinAuth.cs     # Autenticação via Pastebin
¦-- README.md               # Documentação
```

---

## **Contribuindo**  

Contribuições são bem-vindas! Para colaborar:  

```bash
# 1 Faça um fork do projeto
git clone https://github.com/victorhugoscf/Cheat_VIP.git

# 2 Crie uma branch para sua feature
git checkout -b feature/nova-feature

# 3 Commit suas mudanças
git commit -m "Adicionando nova funcionalidade"

# 4 Envie para o GitHub
git push origin feature/nova-feature
```

---

## **Licença**  

Este projeto foi criado para fins educacionais, não me responsabilizo por uso indevido.  

---

## **Contato**  

 **Email:** [victorhugoscf@gmail.com](mailto:victorhugoscf@gmail.com)  
 **GitHub:** [victorhugoscf](https://github.com/victorhugoscf)  

---

### **Gostou do projeto?**  

 **Deixe uma estrela no repositório!** 
