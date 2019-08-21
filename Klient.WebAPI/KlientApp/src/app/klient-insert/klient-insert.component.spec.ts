import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { KlientInsertComponent } from './klient-insert.component';

describe('KlientInsertComponent', () => {
  let component: KlientInsertComponent;
  let fixture: ComponentFixture<KlientInsertComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ KlientInsertComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(KlientInsertComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
