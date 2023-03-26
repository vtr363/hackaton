import { Component ,EventEmitter,Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup,Validators } from '@angular/forms';
import { Login } from 'src/app/Login';



@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  @Output() onSubmit = new  EventEmitter<Login>()
  @Input() btnText!:string

  loginForm!: FormGroup
 

  ngOnInit():void{
    this.loginForm = new FormGroup({
      id: new FormControl(''),
      email:new FormControl('',[Validators.required]),
      senha: new FormControl('',[Validators.required]),
      created_at:new FormControl('',[Validators.required]),
      updated_at:new FormControl('',[Validators.required]),

    });
  }

  get email(){
    return this.loginForm.get('email')!;
  }

  get senha(){
    return this.loginForm.get('senha')!;
  }

  submit(){
    if(this.loginForm.invalid){
      return;
    }
    console.log(this.loginForm.value)

    this.onSubmit.emit(this.loginForm.value);
  }

}


