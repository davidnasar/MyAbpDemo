import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { QAManagementComponent } from './components/q-aManagement.component';
import { QAManagementRoutingModule } from './q-aManagement-routing.module';

@NgModule({
  declarations: [QAManagementComponent],
  imports: [CoreModule, ThemeSharedModule, QAManagementRoutingModule],
  exports: [QAManagementComponent],
})
export class QAManagementModule {
  static forChild(): ModuleWithProviders<QAManagementModule> {
    return {
      ngModule: QAManagementModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<QAManagementModule> {
    return new LazyModuleFactory(QAManagementModule.forChild());
  }
}
