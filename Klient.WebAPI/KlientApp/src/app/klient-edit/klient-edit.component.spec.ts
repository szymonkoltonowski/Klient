import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { KlientEditComponent } from './klient-edit.component';

describe('KlientEditComponent', () => {
  let component: KlientEditComponent;
  let fixture: ComponentFixture<KlientEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ KlientEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(KlientEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
