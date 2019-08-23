import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdresInsertComponent } from './adres-insert.component';

describe('AdresInsertComponent', () => {
  let component: AdresInsertComponent;
  let fixture: ComponentFixture<AdresInsertComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdresInsertComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdresInsertComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
