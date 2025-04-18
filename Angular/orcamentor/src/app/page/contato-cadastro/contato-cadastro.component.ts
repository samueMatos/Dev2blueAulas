import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { ContatoRequest, ContatoService } from '../../services/contato.service';

@Component({
  selector: 'app-contato-cadastro',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './contato-cadastro.component.html',
  styleUrl: './contato-cadastro.component.css'
})
export class ContatoCadastroComponent {
  contatoRequest: ContatoRequest = {
    id: 'Auto',
    nome: '',
    email: '',
    numero: ''
  }


  ngOnInit(): void {
    //buscar por id 
    //atribuir ao contatoReuest
  }


  constructor(private router: Router, private contatoService: ContatoService) { } 

  salvar(form: any){

    if(form.invalid){
      alert('Preencha todos os campos!');
      return;
    }

    if(this.contatoRequest.id === 'Auto'){
      this.contatoRequest.id = '0';
    }

    this.contatoService.salvar(this.contatoRequest).subscribe({
      next: (response) => {
      
        alert('Contato salvo com sucesso! Código: '+ response.id);
        setTimeout(() => this.router.navigate(['/contatos']), 1500);
       
      },
      error: (error) => {
        alert('Erro ao salvar o contato! '+ error);
      }
    }
    );
  }


  voltar(){
    this.router.navigate(['/contatos']);
  }
}
