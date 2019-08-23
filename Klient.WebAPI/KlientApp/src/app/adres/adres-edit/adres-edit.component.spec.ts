import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdresEditComponent } from './adres-edit.component';

describe('AdresEditComponent', () => {
  let component: AdresEditComponent;
  let fixture: ComponentFixture<AdresEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdresEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdresEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
