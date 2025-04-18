import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContatoCadastroComponent } from './contato-cadastro.component';

describe('ContatoCadastroComponent', () => {
  let component: ContatoCadastroComponent;
  let fixture: ComponentFixture<ContatoCadastroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ContatoCadastroComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ContatoCadastroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
