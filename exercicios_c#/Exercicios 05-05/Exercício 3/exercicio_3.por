programa
{
	
	funcao inicio()
	{
		
            caracter Nome
            inteiro Idade
            inteiro Salario
            caracter Civil
            logico varNome = falso
            logico varIdade = falso
            logico varSalario = falso
            logico varCivil = falso

            escreva("Olá! Para se cadastrar em nosso sistema precisamos de algumas informações! ")
            
            faca
            {
                escreva("Digite seu nome:")
                leia(Nome)
                se (Nome == "")
                {
                    escreva("Nenhum nome inserido! ")
                }
                senao
                {
                    varNome = verdadeiro
                }


            } enquanto (varNome == falso)

            faca
            {
                escreva("Digite sua idade: ")
                leia(Idade)

                se ((Idade == 0) ou (Idade > 150))
                {
                    escreva("Idade incorreta! ")
                    
                }
                senao 
                {
                    varIdade = verdadeiro
                }
            } enquanto (varIdade == falso)

            faca
            {
                escreva("Digite sua salário:")
                leia(Salario)
                se (Salario == 0)
                {
                    escreva("Você não recebe um valor menor que zero! ")
                    
                }
                senao
                {
                    varSalario = verdadeiro
                }
            } enquanto (varSalario == falso)
            faca
            {
                escreva(@"
Digite seu estado civil: 
- 's'(solteiro(a)) 
- 'c'(casado(a))
- 'v'(viuvo(a)) 
- 'd'(divorciado(a)):")
                leia(Civil)
                escolha (Civil)
                {
                    caso "":
                        escreva("Espaço em branco!")
                        pare
                      
                    caso "s":
                        escreva("Você é Solteiro(a).")
                        varCivil = verdadeiro
                        pare
                     
                    caso "c":
                        escreva("Você é Casado(a).")
                        varCivil = verdadeiro
                        pare
                        
                    caso "v":
                        escreva("Você é Viuvo(a).")
                        varCivil = verdadeiro
                        pare
                        
                    caso "d":
                        escreva("Você é Divorciado(a).")
                        varCivil = verdadeiro
                        pare
                        
                    caso contrario:
                        escreva("Dado incorreto!")
                        
                }
                
            } enquanto (varCivil == falso)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1657; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */