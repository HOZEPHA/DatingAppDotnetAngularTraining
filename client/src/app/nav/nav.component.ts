import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AccountService } from '../_services/account.service';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { User } from '../_models/user';

@Component({
  selector: 'app-nav',
  imports: [FormsModule, BsDropdownModule],
  templateUrl: './nav.component.html',
  styleUrl: './nav.component.css'
})
export class NavComponent {

  accountService = inject(AccountService);

  model: User |any = {};
  username: string = '';

  login() {
    this.accountService.login(this.model).subscribe({
      next: (response) => {

        console.log(response);
        this.model = response;

      },
      error: (error) => {
        console.log(error);
      },
      complete: () => {
        console.log('Completed');
      }
    });
  }

  logout() {
    this.accountService.logout();
  }
}
