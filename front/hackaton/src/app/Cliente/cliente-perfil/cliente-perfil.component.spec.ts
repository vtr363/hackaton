import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientePerfilComponent } from './cliente-perfil.component';

describe('ClientePerfilComponent', () => {
  let component: ClientePerfilComponent;
  let fixture: ComponentFixture<ClientePerfilComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ClientePerfilComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ClientePerfilComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
