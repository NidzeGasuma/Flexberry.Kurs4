import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  defineProjections,
  ValidationRules,
  Model as Тч_настрMixin
} from '../mixins/regenerated/models/i-i-s-kurs4-тч-настр';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(Тч_настрMixin, Validations, {
});

defineProjections(Model);

export default Model;
