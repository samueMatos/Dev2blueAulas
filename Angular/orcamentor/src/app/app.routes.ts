import { Routes } from '@angular/router';
import { ContainerComponent } from './components/container/container.component';
import { HomeComponent } from './page/home/home.component';
import { LoginComponent } from './page/login/login.component';
import { ContatoCadastroComponent } from './page/contato-cadastro/contato-cadastro.component';

export const routes: Routes = [
    { path: '', redirectTo: '/login', pathMatch: 'full' },
    { path: 'login', component: LoginComponent },
    { path: 'home', component: HomeComponent },
    { path: 'contatos', component: ContainerComponent },
    { path: 'contato-cadastro', component: ContatoCadastroComponent },
    { path: 'contato-cadastro/:id', component: ContatoCadastroComponent },
];
