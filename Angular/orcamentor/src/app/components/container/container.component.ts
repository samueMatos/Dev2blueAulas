import { Component, Input } from '@angular/core';
import { ContatoComponent } from '../contato/contato.component';
import { ContatoService } from '../../services/contato.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-container',
  standalone: true,
  imports: [ContatoComponent],
  templateUrl: './container.component.html',
  styleUrl: './container.component.css',
})
export class ContainerComponent {
  dados: any;
  contatosApi: any;
  servicosApi: any;

  constructor( private contatoService: ContatoService, private router: Router) {  }

  ngOnInit(): void {
    this.obterContatos();
  }

  obterContatos() {
    this.contatoService.obterContatos().subscribe({
      next: (response) => {
        
        this.contatosApi = response;
      },
      error: (erro) => {
        alert('Ocorreu um erro ao buscar os contatos na api => /api/Contatos');
        console.log(`Ocorreu um erro ao realizar a requisição: ${erro}`);        
      },
    });
  }


  editarItem(id: number) {
    this.router.navigate(['/contato-cadastro', id]);
  }

  removeItem(id: number) {
    this.contatoService.excluir(id).subscribe({
      next: (response) => {
        this.obterContatos();
        alert('Contato excluido com sucesso!');
      },
      error: (erro) => {

        if (erro.status === 404) {
          alert('Contato não encontrado!');
          return;
        }

        alert('Ocorreu um erro ao exclir o contato na api => /api/Contatos');
        console.log(`Ocorreu um erro ao realizar a requisição: ${erro}`);        
      },
    });
  }

  filter(filtro: string) {
    this.contatosApi = this.contatos.filter((contato) =>
      contato.nome.toLowerCase().includes(filtro.toLowerCase())
    );
  }

  addItem() {
    this.router.navigate(['/contato-cadastro']);
  }

  @Input() titulo: string = 'Contatos';
  @Input() descricao: string = 'Contatos para realização de orçamentos';
  @Input() notaRodape: string = 'Nota de rodapé importante!';

  contatos: Array<ContatoComponent> = [
    // {
    //   nome: 'Marco Antonio Angelo',
    //   email: 'marco.angelo@gmail.com',
    //   telefone: '(47) 99171-0879',
    // },
    // {
    //   nome: 'José da Silva',
    //   email: 'jose.silva@gmail.com',
    //   telefone: '(47) 99171-0879',
    // },
    // {
    //   nome: 'Maria Antonio',
    //   email: 'maria.antonio@gmail.com',
    //   telefone: '(47) 99171-0879',
    // },
    // {
    //   nome: 'Catarina Bailarina',
    //   email: 'catarina.bailarina@gmail.com',
    //   telefone: '(47) 99171-0879',
    // },
  ];
}

interface Contato {
  nome: string;
  email: string;
  numero: string;
}
