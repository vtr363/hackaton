import { Component ,EventEmitter,Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup,Validators } from '@angular/forms';

import { Cliente } from 'src/app/Cliente';



@Component({
  selector: 'app-cliente-form',
  templateUrl: './cliente-form.component.html',
  styleUrls: ['./cliente-form.component.css']
})
export class ClienteFormComponent {
  @Output() onSubmit = new  EventEmitter<Cliente>()
  //@Input() btnText!:string

  clienteForm!: FormGroup

  btnText:string = 'Cadastrar'

  ngOnInit():void{
    this.clienteForm = new FormGroup({
      id: new FormControl(''),
      nome:new FormControl('',[Validators.required]),
      nomeResponsavel:new FormControl('',[Validators.required]),
      endereco:new FormControl('',[Validators.required]),
      cnpj:new FormControl('',[Validators.required]),
      telefone: new FormControl('',[Validators.required]),
      email:new FormControl('',[Validators.required]),
      created_at:new FormControl('',[Validators.required]),
      updated_at:new FormControl('',[Validators.required]),

    });
  }

  get Nome(){
    return this.clienteForm.get('nome')!;
  }

  get nomeResponsavel(){
    return this.clienteForm.get('nomeResponsavel')!;
  }

  get endereco(){
    return this.clienteForm.get('endereco')!;
  }

  get cnpj(){
    return this.clienteForm.get('cnpj')!;
  }

  get telefone(){
    return this.clienteForm.get('telefone')!;
  }

  get email(){
    return this.clienteForm.get('email')!;
  }



 /*  função responsavel por jogar a imagem dentro do formulario  */
  onFileSelected(event:any){

    const file: File = event.target.files[0];
    this.clienteForm.patchValue({image : file});

  }

  submit(){
    if(this.clienteForm.invalid){
      return;
    }
    console.log(this.clienteForm.value)

    this.onSubmit.emit(this.clienteForm.value);
  }

  

 

}


