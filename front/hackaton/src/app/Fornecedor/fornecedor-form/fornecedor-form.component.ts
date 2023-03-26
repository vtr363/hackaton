import { Component ,EventEmitter,Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup,Validators } from '@angular/forms';
import { Fornecedor } from '../../Fornecedor';


@Component({
  selector: 'app-fornecedor-form',
  templateUrl: './fornecedor-form.component.html',
  styleUrls: ['./fornecedor-form.component.css']
})
export class FornecedorFormComponent {
  @Output() onSubmit = new  EventEmitter<Fornecedor>()
  //@Input() btnText!:string

  fornecedorForm!: FormGroup

 btnText:string = 'Cadastrar'

  ngOnInit():void{
    this.fornecedorForm = new FormGroup({
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
    return this.fornecedorForm.get('nome')!;
  }

  get nomeResponsavel(){
    return this.fornecedorForm.get('nomeResponsavel')!;
  }

  get endereco(){
    return this.fornecedorForm.get('endereco')!;
  }

  get cnpj(){
    return this.fornecedorForm.get('cnpj')!;
  }

  get telefone(){
    return this.fornecedorForm.get('telefone')!;
  }

  get email(){
    return this.fornecedorForm.get('email')!;
  }



 /*  função responsavel por jogar a imagem dentro do formulario  */
  onFileSelected(event:any){

    const file: File = event.target.files[0];
    this.fornecedorForm.patchValue({image : file});

  }

  submit(){
    if(this.fornecedorForm.invalid){
      return;
    }
    console.log(this.fornecedorForm.value)

    this.onSubmit.emit(this.fornecedorForm.value);
  }

  

 

}

