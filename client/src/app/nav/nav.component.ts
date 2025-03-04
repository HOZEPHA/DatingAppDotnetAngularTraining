import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AccountService } from '../_services/account.service';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { User } from '../_models/user';
import { Router, RouterLink, RouterLinkActive } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { TitleCasePipe } from '@angular/common';

@Component({
  selector: 'app-nav',
  imports: [FormsModule, BsDropdownModule, RouterLink, RouterLinkActive, TitleCasePipe],
  templateUrl: './nav.component.html',
  styleUrl: './nav.component.css'
})
export class NavComponent {

  accountService = inject(AccountService);
  private router = inject(Router)
  private toastrService = inject(ToastrService);

  model: User |any = {};
  username: string = '';

  login() {
    this.accountService.login(this.model).subscribe({
      next: (response) => {
      this.toastrService.success('Logged in successfully');
       void this.router.navigateByUrl('/members');  
      },
      error: (error) => {
        this.toastrService.error(error.error);
      },
      complete: () => {
        console.log('Completed');
      }
    });
  }

  logout() {
    this.accountService.logout();
    this.router.navigateByUrl('/');
  }
}
