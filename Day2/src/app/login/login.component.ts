import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
    username: string = '';
  password: string = '';

  onLogin() {
    console.log('Email:', this.username);
    console.log('Password:', this.password);
  }
}
