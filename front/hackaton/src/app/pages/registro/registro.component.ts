import { Component ,EventEmitter,Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup,Validators } from '@angular/forms';
import { Registro } from 'src/app/registro';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent {
  @Output() onSubmit = new  EventEmitter<Registro>()
  //@Input() btnText!:string

  registroForm!: FormGroup

  btnText:string = 'Cadastrar'

  ngOnInit():void{
    this.registroForm = new FormGroup({
      id: new FormControl(''),
      usuario:new FormControl('',[Validators.required]),
      cnpj:new FormControl('',[Validators.required]),
      email:new FormControl('',[Validators.required]),
      senha:new FormControl('',[Validators.required]),
      created_at:new FormControl('',[Validators.required]),
      updated_at:new FormControl('',[Validators.required]),

    });
  }

  get usuario(){
    return this.registroForm.get('usuario')!;
  }

  get cnpj(){
    return this.registroForm.get('cnpj')!;
  }

  get email(){
    return this.registroForm.get('email')!;
  }


  submit(){
    if(this.registroForm.invalid){
      return;
    }
    console.log(this.registroForm.value)

    this.onSubmit.emit(this.registroForm.value);
  }

  

 

}


