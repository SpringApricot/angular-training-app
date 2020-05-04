import { Component } from '@angular/core';

@Component({
    selector: 'app-nav',
    templateUrl: './nav.component.html',
    styleUrls: ['./nav.component.css']
})

/** nav component*/
export class NavComponent {
    model: any = {};

    constructor() {
        //asd
    }

    ngOnInit() {
    }

    login() {
        console.log(this.model);
    }
}
