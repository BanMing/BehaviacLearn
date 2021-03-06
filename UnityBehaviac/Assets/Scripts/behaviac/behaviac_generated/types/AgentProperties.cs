﻿// ---------------------------------------------------------------------
// THIS FILE IS AUTO-GENERATED BY BEHAVIAC DESIGNER, SO PLEASE DON'T MODIFY IT BY YOURSELF!
// ---------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace behaviac
{
	public class CompareValue_FirstEnum : ICompareValue<FirstEnum>
	{
		public override bool Equal(FirstEnum lhs, FirstEnum rhs)
		{
			return lhs == rhs;
		}
		public override bool NotEqual(FirstEnum lhs, FirstEnum rhs)
		{
			return lhs != rhs;
		}
		public override bool Greater(FirstEnum lhs, FirstEnum rhs)
		{
			return lhs > rhs;
		}
		public override bool GreaterEqual(FirstEnum lhs, FirstEnum rhs)
		{
			return lhs >= rhs;
		}
		public override bool Less(FirstEnum lhs, FirstEnum rhs)
		{
			return lhs < rhs;
		}
		public override bool LessEqual(FirstEnum lhs, FirstEnum rhs)
		{
			return lhs <= rhs;
		}
	}

	public class CompareValue_FirstStruct : ICompareValue<FirstStruct>
	{
		public override bool Equal(FirstStruct lhs, FirstStruct rhs)
		{
			return (lhs.s1 == rhs.s1) && (lhs.s2 == rhs.s2);
		}
		public override bool NotEqual(FirstStruct lhs, FirstStruct rhs)
		{
			return !Equal(lhs, rhs);
		}
	}


	public class BehaviorLoaderImplement : BehaviorLoader
	{
		class CInstanceConst_FirstStruct : CInstanceConst<FirstStruct>
		{
			IInstanceMember _s1;
			IInstanceMember _s2;

			public CInstanceConst_FirstStruct(string typeName, string valueStr) : base(typeName, valueStr)
			{
				List<string> paramStrs = behaviac.StringUtils.SplitTokensForStruct(valueStr);
				Debug.Check(paramStrs != null && paramStrs.Count == 2);

				_s1 = (CInstanceMember<int>)AgentMeta.ParseProperty<int>(paramStrs[0]);
				_s2 = (CInstanceMember<float>)AgentMeta.ParseProperty<float>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_s1 != null);
				Debug.Check(_s2 != null);

				_value.s1 = ((CInstanceMember<int>)_s1).GetValue(self);
				_value.s2 = ((CInstanceMember<float>)_s2).GetValue(self);
			}
		};

		private class CMethod_behaviac_Agent_VectorAdd : CAgentMethodVoidBase
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorAdd()
			{
			}

			public CMethod_behaviac_Agent_VectorAdd(CMethod_behaviac_Agent_VectorAdd rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorAdd(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				behaviac.Agent.VectorAdd((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorClear : CAgentMethodVoidBase
		{
			IInstanceMember _param0;

			public CMethod_behaviac_Agent_VectorClear()
			{
			}

			public CMethod_behaviac_Agent_VectorClear(CMethod_behaviac_Agent_VectorClear rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorClear(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);

				behaviac.Agent.VectorClear((IList)_param0.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorContains : CAgentMethodBase<bool>
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorContains()
			{
			}

			public CMethod_behaviac_Agent_VectorContains(CMethod_behaviac_Agent_VectorContains rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorContains(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				_returnValue.value = behaviac.Agent.VectorContains((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorLength : CAgentMethodBase<int>
		{
			IInstanceMember _param0;

			public CMethod_behaviac_Agent_VectorLength()
			{
			}

			public CMethod_behaviac_Agent_VectorLength(CMethod_behaviac_Agent_VectorLength rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorLength(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);

				_returnValue.value = behaviac.Agent.VectorLength((IList)_param0.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorRemove : CAgentMethodVoidBase
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorRemove()
			{
			}

			public CMethod_behaviac_Agent_VectorRemove(CMethod_behaviac_Agent_VectorRemove rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorRemove(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				behaviac.Agent.VectorRemove((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_FirstAgent_Say : CAgentMethodVoidBase
		{
			CInstanceMember<string> _param0;

			public CMethod_FirstAgent_Say()
			{
			}

			public CMethod_FirstAgent_Say(CMethod_FirstAgent_Say rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_FirstAgent_Say(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				_param0 = (CInstanceMember<string>)AgentMeta.ParseProperty<string>(paramStrs[0]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);

				string param0 = ((CInstanceMember<string>)_param0).GetValue(self);
				Agent agent = Utils.GetParentAgent(self, _instance);

				((FirstAgent)agent).Say(ref param0);
				_param0.SetValue(self, param0);
			}
		}


		public override bool Load()
		{
			AgentMeta.TotalSignature = 1896202473;

			AgentMeta meta;

			// behaviac.Agent
			meta = new AgentMeta(24743406);
			AgentMeta._AgentMetas_[2436498804] = meta;
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { behaviac.Agent.LogMessage(param0); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());

			// FirstAgent
			meta = new AgentMeta(3588288675);
			AgentMeta._AgentMetas_[1778122110] = meta;
			meta.RegisterMemberProperty(2082220067, new CMemberProperty<int>("p1", delegate(Agent self, int value) { ((FirstAgent)self)._set_p1(value); }, delegate(Agent self) { return ((FirstAgent)self)._get_p1(); }));
			meta.RegisterMemberProperty(1462860768, new CMemberProperty<FirstStruct>("p2", delegate(Agent self, FirstStruct value) { ((FirstAgent)self)._set_p2(value); }, delegate(Agent self) { return ((FirstAgent)self)._get_p2(); }));
			meta.RegisterMemberProperty(1311394465, new CMemberProperty<FirstEnum>("p3", delegate(Agent self, FirstEnum value) { ((FirstAgent)self)._set_p3(value); }, delegate(Agent self) { return ((FirstAgent)self)._get_p3(); }));
			meta.RegisterMemberProperty(1144200279, new CMemberProperty<System.Object>("pInstance", delegate(Agent self, System.Object value) { ((FirstAgent)self)._set_pInstance(value); }, delegate(Agent self) { return ((FirstAgent)self)._get_pInstance(); }));
			meta.RegisterMethod(3345343196, new CAgentMethodVoid<int>(delegate(Agent self, int param0) { }) /* event_task */);
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { FirstAgent.LogMessage(param0); }));
			meta.RegisterMethod(702722749, new CMethod_FirstAgent_Say());
			meta.RegisterMethod(1505908390, new CAgentMethodVoid(delegate(Agent self) { ((FirstAgent)self).SayHello(); }));
			meta.RegisterMethod(2645266540, new CAgentMethod<behaviac.EBTStatus, string, bool>(delegate(Agent self, string value, bool isLatent) { return ((FirstAgent)self).Says(value, isLatent); }));
			meta.RegisterMethod(664995375, new CAgentMethod<behaviac.EBTStatus>(delegate(Agent self) { return ((FirstAgent)self).Start(); }));
			meta.RegisterMethod(2065006847, new CAgentMethodVoid<int>(delegate(Agent self, int param0) { }) /* t1 */);
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());
			meta.RegisterMethod(994837275, new CAgentMethod<behaviac.EBTStatus>(delegate(Agent self) { return ((FirstAgent)self).Wait(); }));

			// SecondAgent
			meta = new AgentMeta(2420330950);
			AgentMeta._AgentMetas_[2432194202] = meta;
			meta.RegisterMemberProperty(1462860768, new CMemberProperty<int>("p2", delegate(Agent self, int value) { ((SecondAgent)self)._set_p2(value); }, delegate(Agent self) { return ((SecondAgent)self)._get_p2(); }));
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { SecondAgent.LogMessage(param0); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());

			AgentMeta.Register<behaviac.Agent>("behaviac.Agent");
			AgentMeta.Register<FirstAgent>("FirstAgent");
			AgentMeta.Register<SecondAgent>("SecondAgent");
			AgentMeta.Register<FirstEnum>("FirstEnum");
			ComparerRegister.RegisterType<FirstEnum, CompareValue_FirstEnum>();
			AgentMeta.Register<FirstStruct>("FirstStruct");
			ComparerRegister.RegisterType<FirstStruct, CompareValue_FirstStruct>();

			Agent.RegisterInstanceName<SecondAgent>("SecondAgentInstance");
			return true;
		}

		public override bool UnLoad()
		{
			AgentMeta.UnRegister<behaviac.Agent>("behaviac.Agent");
			AgentMeta.UnRegister<FirstAgent>("FirstAgent");
			AgentMeta.UnRegister<SecondAgent>("SecondAgent");
			AgentMeta.UnRegister<FirstEnum>("FirstEnum");
			AgentMeta.UnRegister<FirstStruct>("FirstStruct");

			Agent.UnRegisterInstanceName<SecondAgent>("SecondAgentInstance");
			return true;
		}
	}
}
