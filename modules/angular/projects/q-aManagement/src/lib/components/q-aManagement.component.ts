import { Component, OnInit } from '@angular/core';
import { QAManagementService } from '../services/q-aManagement.service';

@Component({
  selector: 'lib-q-aManagement',
  template: ` <p>q-aManagement works!</p> `,
  styles: [],
})
export class QAManagementComponent implements OnInit {
  constructor(private service: QAManagementService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
